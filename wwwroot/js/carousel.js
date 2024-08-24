window.initializeOwlCarousel = () => {
    var owlOne = $("#owl-demo");
    owlOne.owlCarousel({
        responsiveClass: true,
        responsive: {
            0: {
                items: 1,
            },
            800: {
                items: 2,
                },
            1138: {
                items: 3,
            }
        }
    });

    $(".next").click(function () {
        owlOne.trigger('next.owl.carousel');
    });
    $(".prev").click(function () {
        owlOne.trigger('prev.owl.carousel');
    });
};
