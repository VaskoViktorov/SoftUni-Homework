function roadRadar([currentSpeed, place]) {

    let condition = checker(currentSpeed,getLimit(place));

    if(condition !== 0){
        return console.log(condition);
    }

    function checker(speed,limit) {

        let overSpeed =speed-limit;

        if(overSpeed<=0){
            return 0;
        }else if(overSpeed<=20){
            return "speeding";
        }else if(overSpeed<=40){
            return "excessive speeding";
        }else{
            return "reckless driving";
        }

    }

    function getLimit(zone) {
        switch (zone) {
            case 'motorway': return 130;
            case 'interstate': return 90;
            case 'city': return 50;
            case 'residential': return 20;

        }
    }
}
