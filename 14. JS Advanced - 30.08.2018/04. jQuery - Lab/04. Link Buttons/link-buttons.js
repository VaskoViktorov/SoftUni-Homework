function attachEvents() {
    $(".button").on('click', markButton);

    function markButton() {
        $(".selected").removeClass("selected");
        $(this).addClass("selected");
    }
}
