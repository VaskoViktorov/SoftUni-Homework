function diagonalAttack(matrix) {
    let leftDiagonalPosition=0;
    let rightDiagonalPosition = matrix.length-1;
    let diagonalSums = [0,0];

    for (let col = 0; col < matrix.length; col++) {
        diagonalSums[0]+=matrix[col][leftDiagonalPosition];
        diagonalSums[1]+=matrix[col][rightDiagonalPosition];
        leftDiagonalPosition++;
        rightDiagonalPosition--;
    }

    if(diagonalSums[0] !==diagonalSums[1]){
       console.log(matrix.map(row => row.join(" ")).join("\n"));
    }
    leftDiagonalPosition=0;
    rightDiagonalPosition = matrix.length-1;

    for (let col = 0; col < matrix.length; col++) {
        for (let row = 0; row <matrix[col].length ; row++) {
            if(row !==leftDiagonalPosition && row !== rightDiagonalPosition){
                matrix[col][row]=diagonalSums[0];
            }
        }
        leftDiagonalPosition++;
        rightDiagonalPosition--;

    }

    console.log(matrix.map(row => row.join(" ")).join("\n"));

}
diagonalAttack([[5,3,12,3,1],
                [11,4,23,2,5],
                [101,12,3,21,10],
                [1,4,5,2,2],
                [5,22,33,11,8]])