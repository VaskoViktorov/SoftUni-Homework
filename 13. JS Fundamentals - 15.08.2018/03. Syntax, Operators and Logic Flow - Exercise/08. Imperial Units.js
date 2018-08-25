function convertor(inches) {

    inches = Number(inches);
    let feet = Number.parseInt(inches/12);
    inches = inches % 12;

    return `${feet}'-${inches}"`
}