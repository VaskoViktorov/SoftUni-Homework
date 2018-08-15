function fruitOrVegetable(word) {
    switch (word) {
        case "banana":
        case "apple":
        case "grapes":
        case "kiwi":
        case "cherry":
        case "lemon":
        case "peach":
            console.log("fruit");
            break;
        case "tomato":
        case "cucumber":
        case "pepper":
        case "onion":
        case "garlic":
        case "parsley":
            console.log("vegetable");
            break;
        default:
            console.log("unknown");
            break;
    }
}