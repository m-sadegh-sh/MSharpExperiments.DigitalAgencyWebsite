export default class ClientsCarouselModule {
    public static run = () => ($ => {
        const transitionDuration = 3000;
        const chunkDuration = 600;
        let forward = true;
        let autoMoveId = null;

        const $carouselModule = $('[data-module="ClientsCarouselList"]');
        const $carouselItemsWrapper = $carouselModule.find('.list-items');
        const $carouselIcons = $carouselModule.find('.paging-icons button');
        const $carouselPrev = $carouselIcons.filter('.prev');
        const $carouselNext = $carouselIcons.filter('.next');

        const moveToPrevItem = () => {
            blockIcons();

            const $lastItem = $carouselItemsWrapper.children().last();
            const $clonedItem = $lastItem.clone();

            $lastItem.addClass('hiding');
            $clonedItem.addClass('hided');

            $carouselItemsWrapper.prepend($clonedItem);

            setTimeout(() => $clonedItem.addClass('showing'), 1);

            setTimeout(() => {
                $lastItem.remove();
                $clonedItem.removeClass('hided showing');
                unblockIcons();
            }, chunkDuration);
        };

        const moveToNextItem = () => {
            blockIcons();

            const $firstItem = $carouselItemsWrapper.children().first();
            const $clonedItem = $firstItem.clone();

            $firstItem.addClass('hiding');
            $clonedItem.addClass('hided');

            $carouselItemsWrapper.append($clonedItem);

            setTimeout(() => $clonedItem.addClass('showing'), 1);

            setTimeout(() => {
                $firstItem.remove();
                $clonedItem.removeClass('hided showing');
                unblockIcons();
            }, chunkDuration);
        };

        const updateDirection = () => {
            $carouselItemsWrapper
                .removeClass('backward forward')
                .addClass(forward ? 'forward' : 'backward');
        };

        const changeDirection = value => {
            forward = value;
            updateDirection();
        };

        const startAutoRotate = () => {
            updateDirection();
            clearAutoRotate();
            autoMoveId = setInterval(moveToNextItem, transitionDuration);
        };

        const clearAutoRotate = () => autoMoveId && clearInterval(autoMoveId);

        const blockIcons = () => $carouselIcons.addClass('busy');

        const unblockIcons = () => $carouselIcons.removeClass('busy');

        $carouselPrev.on('click', function () {
            changeDirection(false);
            blockIcons();
            clearAutoRotate();
            moveToPrevItem();

            setTimeout(() => {
                startAutoRotate();
                unblockIcons();
            }, transitionDuration);
        });

        $carouselNext.on('click', function () {
            changeDirection(true);
            blockIcons();
            clearAutoRotate();
            moveToNextItem();

            setTimeout(() => {
                startAutoRotate();
                unblockIcons();
            }, transitionDuration);
        });

        startAutoRotate();
    })(jQuery);
}