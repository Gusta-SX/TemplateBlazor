window.initializeSwiper = () => {
    var swiper = new Swiper('.swiper-container', {
        slidesPerGroup: 1,
        loop: true,
        loopFillGroupWithBlank: true,
        pagination: {
            el: '.swiper-pagination',
            clickable: true,
        },
        navigation: {
            nextEl: '.swiper-button-next',
            prevEl: '.swiper-button-prev',
        },
        breakpoints: {
            700: {
                slidesPerView: 2,
                spaceBetween: 0,
            },
            1080: {
                slidesPerView: 3,
                spaceBetween: 0,
            },
            1700: {
                slidesPerView: 4,
                spaceBetween: 0,
            },
        }
    });
}

function scrollToPropos() {
    document.querySelector('#propose-content').scrollIntoView();
}

// FUNÇÃO DE MUDAR NA MESMA DIV
function makeActiveTab(num) {
    const buttons = document.querySelectorAll('.btn-div button')
    buttons.forEach(btn => {
        btn.classList.remove('active');
    });
    document.querySelector('.btn-div .btn-' + num).classList.add('active');

    const contents = document.querySelectorAll('.imv-image .inner')
    contents.forEach(cnt => {
        cnt.classList.remove('active');
    });
    document.querySelector('.imv-image .content-' + num).classList.add('active');
}