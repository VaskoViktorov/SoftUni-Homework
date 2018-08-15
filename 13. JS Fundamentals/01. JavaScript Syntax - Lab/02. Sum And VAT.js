function sumAndVAT(input) {
    let sum = 0;

    for (let num of input) {
        sum+=num;
    }

    let vat = sum*0.2;
    let total = sum+vat;

    console.log(`sum = ${sum}`);
    console.log(`VAT = ${vat}`);
    console.log(`total = ${total}`);
}
