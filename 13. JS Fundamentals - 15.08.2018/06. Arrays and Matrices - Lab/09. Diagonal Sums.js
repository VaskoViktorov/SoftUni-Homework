function diagonalSum(matrix) {

    let leftDiagonalPosition=0;
    let rightDiagonalPosition = matrix.length-1;
    let diagonalSums = [0,0];

    for (let col = 0; col < matrix.length; col++) {
        diagonalSums[0]+=matrix[col][leftDiagonalPosition];
        diagonalSums[1]+=matrix[col][rightDiagonalPosition];
        leftDiagonalPosition++;
        rightDiagonalPosition--;
    }

    return console.log(diagonalSums.join(" "))
}
