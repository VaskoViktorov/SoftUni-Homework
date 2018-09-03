function timer() {
    let sec=0;
    let intervalId;
    let isRunning = false;

    $('#start-timer').on('click', function () {
        if(! isRunning){
            intervalId = setInterval(incrementTime, 1000);
            isRunning = true;
        }
    });

    $('#stop-timer').on('click', function () {
        clearInterval(intervalId);
        isRunning = false;
    });

    function incrementTime() {
        sec++;
        let hours = Math.floor(sec / 60 / 60)%60;
        let minutes = Math.floor(sec / 60)%60;
        let seconds = sec % 60;
        $('#hours').text((hours < 10 ? '0' + hours : hours));
        $('#minutes').text((minutes < 10 ? '0' + minutes : minutes));
        $('#seconds').text((seconds < 10 ? '0' + seconds : seconds));
    }
}

