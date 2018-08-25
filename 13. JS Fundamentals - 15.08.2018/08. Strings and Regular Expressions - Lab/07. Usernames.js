function userNames(input) {
    let users = [];

    for(let email of input) {
        let tokens = email.split('@');
        let username = tokens[0] + '.';
        tokens[1].split('.').forEach(x => username += x[0]);
        users.push(username);
    }

    console.log(users.join(", "));
}

userNames(['pesh.oo@gmail.com', 'todor_43@mail.dir.bg', 'foo@bar.com']);
