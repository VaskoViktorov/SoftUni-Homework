let solution = (function () {
    let robot = {
        protein: 0,
        carbohydrate: 0,
        fat: 0,
        flavour: 0
    };
    let recipes = {
        apple: function () {
            robot.carbohydrate -= 1;
            robot.flavour -= 2;
        },
        coke: function () {
            robot.carbohydrate -= 10;
            robot.flavour -= 20;
        },
        burger: function () {
            robot.carbohydrate -= 5;
            robot.fat -= 7;
            robot.flavour -= 3;
        },
        omelet: function () {
            robot.protein -= 5;
            robot.fat -= 1;
            robot.flavour -= 1;
        },
        cheverme: function () {
            robot.protein -= 10;
            robot.carbohydrate -= 10;
            robot.fat -= 10;
            robot.flavour -= 10;
        },
    };

    return function (input) {

        let args = input.split(' ');

        if (args[0] === 'restock') {
            robot[args[1]] += Number(args[2]);
            return 'Success';

        } else if (args[0] === 'prepare') {

            let robotHolder = {
                protein: robot.protein,
                carbohydrate: robot.carbohydrate,
                fat: robot.fat,
                flavour: robot.flavour
            };

            let errorRecipe = function (product) {
                robot = robotHolder;
                return `Error: not enough ${product} in stock`
            };

            for (let i = 0; i < Number(args[2]); i++) {
                recipes[args[1]]();
            }

            if (robot.carbohydrate < 0) return errorRecipe('carbohydrate');
            else if (robot.protein < 0) return errorRecipe('protein');
            else if (robot.fat < 0)     return errorRecipe('fat');
            else if (robot.flavour < 0) return errorRecipe('flavour');
            else                        return 'Success';

        } else if (args[0] === 'report') {
            return `protein=${robot.protein} carbohydrate=${robot.carbohydrate} fat=${robot.fat} flavour=${robot.flavour}`
        }
    }
})();


console.log(solution('prepare cheverme 1'));
console.log(solution('restock protein 10'));
console.log(solution('prepare cheverme 1'));
console.log(solution('restock carbohydrate 10'));
console.log(solution('prepare cheverme 1'));
console.log(solution('restock fat 10'));
console.log(solution('prepare cheverme 1'));
console.log(solution('restock flavour 10'));
console.log(solution('prepare cheverme 1'));
console.log(solution('report'));
