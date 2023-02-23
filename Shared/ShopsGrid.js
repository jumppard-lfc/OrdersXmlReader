function changeRowColor() {
    let greenElements = document.querySelectorAll('span.green');
    if (redElements) {
        redElements.forEach((element) => {
            let parent = element.parentNode.parentNode;
            parent.classList.add('bg-success');
            parent.classList.add('text-white');
            parent.classList.add('bg-opacity-75');
        });
    }

    let redElements = document.querySelectorAll('span.red');
    redElements.forEach((element) => {
        let parent = element.parentNode.parentNode;
        parent.classList.add('bg-warning');
        parent.classList.add('text-dark');
        parent.classList.add('bg-opacity-75');
    });
}