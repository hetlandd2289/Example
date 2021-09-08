module.exports - {
    "parserOptions": {
        "ecmaVersion": 6
    }
}


const name = document.getElementById('name')
const password = document.getElementById('email')
const form = document.getElementById('form')

form.addEventListener('submit', (e) => {
    e.preventDefault()
})