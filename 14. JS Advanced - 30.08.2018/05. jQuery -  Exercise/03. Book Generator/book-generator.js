(function createBook () {
    let id = 1;
    return function (selector, titleName, authorName, isbn) {

        $(selector)
            .append($('<div>').attr('id', 'book' + id)
            .append($(`<p>${titleName}</p>`).addClass('title'))
            .append($(`<p>${authorName}</p>`).addClass('author'))
            .append($(`<p>${isbn}</p>`).addClass('isbn'))
            .append($('<button>Select</button>').on('click', select))
            .append($('<button>Deselect</button>').on('click', deselect)));

        function select() {
            $(this).parent().css('border', '2px solid blue');
        }

        function deselect() {
            $(this).parent().css('border', '');
        }

        id++;
    }

}());
