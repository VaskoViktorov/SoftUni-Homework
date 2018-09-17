function solve(arr) {
    let arrOfRectangles = [];

    for (let rect of arr){
        arrOfRectangles.push(createRect(Number(rect[0]),Number(rect[1])));
    }

    return arrOfRectangles.sort((a,b) => a.compareTo(b));

    function createRect(w,h) {
        return {
            width: w,
            height: h,
            area: function () {
                return w*h;
            },
            compareTo: function (other) {
                return other.area() - this.area() || other.width-this.width
            }
        }
    }
}

console.log(solve([[1,20],[20,1],[5,3],[5,3]]));

