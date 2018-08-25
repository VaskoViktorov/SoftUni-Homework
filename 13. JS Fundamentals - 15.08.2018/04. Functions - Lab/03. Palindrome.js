function palindrome(text) {

   let reversedText = text.split("").reverse().join("");

   if(text===reversedText){
       return console.log("true");
   }

   return console.log("false");
}

