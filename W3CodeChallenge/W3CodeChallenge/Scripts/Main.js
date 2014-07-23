$(document).ready(function () {
   
    $('.about > li').on('click', function () {
        // use a .get request to update the data
        var url = $(this).data('url');
        // use a .get requewt to update ourt content
        $.get(url, function (data) {
            //data returned from our GET request
            $('#tabContent').html(data);
        });
    });
});