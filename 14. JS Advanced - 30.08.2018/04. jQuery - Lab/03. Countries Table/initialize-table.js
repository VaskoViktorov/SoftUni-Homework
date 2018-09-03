function initializeTable() {

    createRow('Bulgaria', 'Sofia');
    createRow('Germany', 'Berlin');
    createRow('Russia', 'Moscow');
    $('#createLink').on('click', readInput);

    function readInput() {
        let country = $("#newCountryText").val();
        let capital = $("#newCapitalText").val();
        createRow(country, capital);
    }

    function createRow(country, capital) {
        $("<tr>")
            .append($(`<td>${country}</td>`))
            .append($(`<td>${capital}</td>`))
            .append($(`<td>`)
                .append($("<a href='#'>[Up]</a>").on('click', moveUp))
                .append($("<a href='#'>[Down]</a>").on('click', moveDown))
                .append($("<a href='#'>[Delete]</a>").on('click', DeleteRow)))
            .appendTo("#countriesTable");
        fixTable();
    }

    function moveUp() {
        let row = $(this).parent().parent();
        row.fadeOut(function () {
            row.insertBefore(row.prev());
            row.fadeIn();
            fixTable();
        });
    }
        function moveDown() {
            let row = $(this).parent().parent();
            row.fadeOut(function () {
                row.insertAfter(row.next());
                row.fadeIn();
                fixTable();
            });
        }

        function DeleteRow() {
            $(this).parent().parent().remove();
            fixTable();
        }

        function fixTable() {
            // Show all links in the table
            $('#countriesTable a').css('display', 'inline');

            // Hide [Up] link in first table data row
            let tableRows = $('#countriesTable tr');

            $(tableRows[2]).find("a:contains('Up')")
                .css('display', 'none');

            // Hide the [Down] link in the last table row
            $(tableRows[tableRows.length - 1]).find("a:contains('Down')")
                .css('display', 'none');
        }

}
