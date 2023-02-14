let btn = document.querySelectorAll('li');
let dataElement = document.querySelector('#data-display')

btn.forEach(x => {
    x.addEventListener('click', e => fetchData(e))
})

function fetchData(event){
    fetch(`http://localhost:5213/home/calc?op=${encodeURIComponent(event.target.innerHTML)}`)
        .then((response) => response.json())
        .then((data) => dataElement.innerHTML = data.result);
}