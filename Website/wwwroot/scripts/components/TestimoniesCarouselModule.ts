export default class TestimoniesCarouselModule {
    public static run = () => ($ => {
        const bodyStyles = window.getComputedStyle(document.body);
        const carouselItemWidth = bodyStyles.getPropertyValue('--slides-carousel-item-width');

        const $carouselModule = $('[data-module="TestimoniesCarouselList"]');
        const $carouselItemsWrapper = $carouselModule.find('.list-items');
        const $carouselPagers = $carouselModule.find('.paging-indicators li');

        $carouselPagers.each((index, page) => $(page).on('click', function () {
            $carouselPagers.removeClass('current');
            $(this).addClass('current');
            $carouselItemsWrapper.css("left", `calc(-${index} * ${carouselItemWidth})`);
        }));
    })(jQuery);
}