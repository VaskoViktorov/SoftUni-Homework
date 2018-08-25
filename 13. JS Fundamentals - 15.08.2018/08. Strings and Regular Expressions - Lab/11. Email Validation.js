function emailValidation(input) {
    let regex = /^[A-Za-z0-9]+@[a-z]+.[a-z]+$/;

    console.log(regex.test(input)? 'Valid':'Invalid')
}

emailValidation('valid@email.bg');