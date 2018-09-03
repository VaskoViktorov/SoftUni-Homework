function validate() {
    $('#company').on('change', showHideCompany);

    $('#submit').on('click', function (ev) {
        ev.preventDefault();
        let usernameRegex = /^[a-zA-Z0-9]{3,20}$/;
        let passwordRegex = /^\w{5,15}$/;
        let emailRegex = /@.*\./;
        let companyNumberRegex = /^[1-9]{1}[0-9]{3}$/;

        let allFieldsValid = true;

        let username = $('#username');
        let password = $('#password');
        let email = $('#email');
        let confirmPass = $('#confirm-password');
        let companyNum = $('#companyNumber');


        checker(username.val().match(usernameRegex), username);
        checker(password.val().match(passwordRegex), password);
        checker(email.val().match(emailRegex), email);
        checker(confirmPass.val().match(passwordRegex) && $(confirmPass).val().localeCompare($(password).val()) === 0, confirmPass);

        if ($('#company').is(':checked')) {
            checker($(companyNum).val().match(companyNumberRegex), companyNum);
        }

        if (allFieldsValid) {
            $('#valid').css('display', 'block');
        } else {
            $('#valid').css('display', 'none');
        }

        function checker(isCorrect, value) {
            if (isCorrect) {
                return value.css('border', 'none');
            }
            else {
                value.css('border-color', 'red');
                allFieldsValid = false;
            }
        }
    });

    function showHideCompany() {
        if ($(this).is(':checked')) {
            $('#companyInfo').css('display', 'block');
        } else {
            $('#companyInfo').css('display', 'none')
        }
    }
}