function adjustConstructor(obj){

    if(obj.handsShaking){
        obj.bloodAlcoholLevel+= obj.weight*obj.experience*0.1;
        obj.handsShaking = false;
    }

    return obj;
}

console.log(adjustConstructor({ weight: 80,
    experience: 1,
    bloodAlcoholLevel: 0,
    handsShaking: true }))