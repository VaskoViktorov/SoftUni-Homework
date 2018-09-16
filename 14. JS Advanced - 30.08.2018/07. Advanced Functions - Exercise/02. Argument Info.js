function result() {

    let summary = {
        'string':0,
        'number':0,
        'function':0,
    };
    for (let i = 0; i <arguments.length ; i++) {
        let obj = arguments[i];
        let type = typeof obj;
        console.log(type+': '+obj);

        if(!summary[type]){
            summary[type]=1;
        }else{
            summary[type]++;
        }

    }

    let sorted = Object.keys(summary).sort((a, b) => summary[b] - summary[a]);
    for(let type of sorted){
        if(summary[type] !== 0){
            console.log(`${type} = ${summary[type]}`)
        }
    }
}

result( 'bob', 3.333, 9.999);