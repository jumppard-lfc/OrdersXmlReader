function changeRowColor() {
    let greenElements = document.querySelectorAll('span.green');
    if (greenElements) {
        greenElements.forEach((element) => {
            let parent = element.parentNode.parentNode;
            parent.classList.add('bg-green');
            parent.classList.add('text-dark');
            parent.classList.add('bg-opacity-75');
        });
    }

    let redElements = document.querySelectorAll('span.red');
    redElements.forEach((element) => {
        let parent = element.parentNode.parentNode;
        parent.classList.add('bg-red');
        parent.classList.add('text-dark');
        parent.classList.add('bg-opacity-75');
    });

    let orangeElements = document.querySelectorAll('span.orange');
    orangeElements.forEach((element) => {
        let parent = element.parentNode.parentNode;
        parent.classList.add('bg-orange');
        parent.classList.add('text-dark');
        parent.classList.add('bg-opacity-75');
    });

    let grayElements = document.querySelectorAll('span.gray');
    grayElements.forEach((element) => {
        let parent = element.parentNode.parentNode;
        parent.classList.add('bg-gray');
        parent.classList.add('text-dark');
        parent.classList.add('bg-opacity-75');
    });
}
