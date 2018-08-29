function a(input) {

    let catalogue = new Map;

    for (let i = 0; i < input.length; i++) {
        let current = input[i].split(':');

        let productName = current[0];
        let productPrice = Number(current[1]);
        let productFistLetter = productName[0];


        if (!catalogue.has(productFistLetter)) {

            catalogue.set(productFistLetter, new Map())
        }
        if (!catalogue.get(productFistLetter).has(productName)) {
            catalogue.get(productFistLetter).set(productName, 0)
        }
        catalogue.get(productFistLetter).set(productName, productPrice)
    }
    function alphabeticalSort(a, b) {
        return a[0].localeCompare(b[0])
    }
    let sortedInitials = [...catalogue].sort(alphabeticalSort);

    for (let [key,value]of sortedInitials) {
        console.log(key);
        let sortedProducts = [...value].sort(alphabeticalSort);
        for (let [products,price] of sortedProducts) {
            console.log("  " + products.trim() + ": " + price);
        }
    }


}
a(['Appricot : 20.4', 'Fridge : 1500', 'TV : 1499', 'Deodorant : 10', 'Boiler : 300', 'Anti-Bug Spray : 15', 'T-Shirt : 10']);