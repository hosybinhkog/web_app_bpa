const header = document.querySelector('.header');
console.log("header", header)

//handle scroll > 80 


window.addEventListener('scroll', () => {
    if (document.body.scrollTop > 80 || document.documentElement.scrollTop > 80 || window.scrollY > 80) {
        header.classList.add('shrink');
    } else {
        header.classList.remove('shrink')
    }
})