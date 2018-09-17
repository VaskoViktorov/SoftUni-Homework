function carFactory(car) {
    let newCar = {};

    newCar.model = car.model;

    let engines = [
        {power: 90, volume: 1800},
        {power: 120, volume: 2400},
        {power: 200, volume: 3500}];

    if (car.power <= 90) {
        newCar.engine = engines[0];
    } else if (car.power <= 120) {
        newCar.engine = engines[1];
    } else {
        newCar.engine = engines[2];
    }

    newCar.carriage = {
        type: car.carriage,
        color: car.color};

    let newCarWheelsSize = car.wheelsize;

    if (car.wheelsize % 2 === 0) {
        newCarWheelsSize = car.wheelsize - 1;
    }

    newCar.wheels = [newCarWheelsSize, newCarWheelsSize, newCarWheelsSize, newCarWheelsSize];

    return newCar;
}


console.log(carFactory({
        model: 'VW Golf II',
        power: 90,
        color: 'blue',
        carriage: 'hatchback',
        wheelsize: 14
    }
));






