// Initialize your app
var myApp = new Framework7({
    statusbarOverlay: false
});

// Export selectors engine
var $$ = Dom7;

// 3 Slides Per View, 10px Between
var mySwiper3 = myApp.swiper('.swiper-3', {
    pagination: '.swiper-3 .swiper-pagination',
    spaceBetween: 10,
    slidesPerView: 3
});