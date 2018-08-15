function ageFilter(minAge,fpName,fpAge,spName,spAge) {
    let fp = {name:fpName, age:fpAge};
    let sp = {name:spName, age:spAge};

    if(fp.age>=minAge){
        console.log(fp);
    }
    if(sp.age>=minAge){
        console.log(sp);
    }
}

