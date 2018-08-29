function townsToJSON(arr) {

   arr.shift();
   let towns = [];
    for(let town of arr){

        let [ townName, lat, lng] = town.split(/\s*\|\s*/).filter(x => x !== '');
        let currTown={Town: townName,Latitude: Number(lat),Longitude: Number(lng)};
        towns.push(currTown);
    }

   console.log(JSON.stringify(towns))
}

townsToJSON(['| Town | Latitude | Longitude |',
'| Sofia | 42.696552 | 23.32601 |',
'| Beijing | 39.913818 | 116.363625 |']);