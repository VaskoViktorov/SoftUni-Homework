function listOfCommands(commands) {

    let result = createObj();

    for (let row of commands) {
        row = row.split(' ');
        let command = row[0];
        switch (command) {
            case "add":
                result.add(row[1]);
                break;
            case "remove":
                result.remove(row[1]);
                break;
            case "print":
                console.log(result.print());
                break;
        }
    }

    function createObj() {
        let list = [];

        return {
            add: function (input) {
                list.push(input);
            },
            remove: function (input) {
                list = list.filter(a => a !== input);
            },
            print: function () {
                return list.toString()
            }
        }
    }
}



listOfCommands(['add pesho', 'add gosho', 'add pesho', 'remove pesho','print']);