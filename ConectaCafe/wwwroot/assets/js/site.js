let elements = document.querySelectorAll('input[type="text"], select, textarea');
console.log(elements)
elements.forEach((elem, index, array) => {
    if(elem.value != ""){
        elem.parentElement.classList.add('is-filled');
    }
});
