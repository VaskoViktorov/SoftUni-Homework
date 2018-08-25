function countOccurrences(word, string) {
  let startIndex = 0;
  let counter = 0;

  while (startIndex !== string.length){

      if(word === string.slice(startIndex,startIndex+word.length)){
          counter++;
      }
      startIndex++;
  }
    console.log(counter);
}

countOccurrences('ma', 'Marine mammal training is the training ' +
'and caring for marine life such as, dolphins, killer whales, ' +
'sea lions, walruses, and other marine mammals. It is also a duty ' +
'of the trainer to do mental and physical exercises to keep the animal healthy and happy.');