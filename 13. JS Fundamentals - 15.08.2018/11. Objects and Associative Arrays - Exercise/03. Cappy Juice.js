function a(input) {

    let totalJuice = new Map;
    let totalBottles = new Map;

    for (let i = 0; i < input.length; i++) {

        let current = input[i].split('=>');

        let fruit = current[0];
        let quantity = Number(current[1]);

        if (!totalJuice.has(fruit)) {
            totalJuice.set(fruit, 0);
        }

        let currentQuantity = totalJuice.get(fruit);
        currentQuantity += quantity;

        if (currentQuantity >= 1000) {
            let juiceLeft = currentQuantity % 1000;

            let bottlesToStore = (currentQuantity - juiceLeft) / 1000;

            if (!totalBottles.has(fruit)) {
                totalBottles.set(fruit, 0)
            }

            totalBottles.set(fruit, totalBottles.get(fruit) + bottlesToStore);
            quantity = juiceLeft;
        }
        totalJuice.set(fruit, totalJuice.get(fruit) + quantity);

    }
    for (let [juice,bottles]of totalBottles) {
        console.log(juice + "=> " + bottles);
    }
}
a(['Orange => 2000', 'Peach => 1432', 'Banana => 450', 'Peach => 600', 'Strawberry => 549']);