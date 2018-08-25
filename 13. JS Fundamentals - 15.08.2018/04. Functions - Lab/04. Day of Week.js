function dayOfWeek(text) {

    let weekDay = [,"Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"];

    for (let i = 0; i <weekDay.length ; i++) {
        if(weekDay[i]===text){
            return console.log(i);
        }
    }
    return console.log("error");
}

dayOfWeek("Monday")