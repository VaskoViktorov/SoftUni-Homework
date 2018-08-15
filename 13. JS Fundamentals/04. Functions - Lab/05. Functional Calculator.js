function functionalCalculator(firstNum,secondNum,operator) {
   function sum() { return console.log(firstNum+secondNum);}
   function subtract() { return console.log(firstNum-secondNum);}
   function multiply() { return console.log(firstNum*secondNum);}
   function divide() { return console.log(firstNum/secondNum);}

   switch (operator) {
       case "+":
           sum();
           break;
       case "-":
           subtract();
           break;
       case "*":
           multiply();
           break;
       case "/":
           divide();
           break;
   }
}