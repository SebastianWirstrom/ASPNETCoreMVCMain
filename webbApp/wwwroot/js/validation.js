const formErrorHandler = (e, validationResult) => {
    let spanElement = document.querySelector(`[data-valmsg-for="${e.target.name}"]`)

    if (validationResult) {
        e.target.classList.remove('input-validator-error')
        spanElement.classList.remove('field-validation-error')
        spanElement.classList.add('field-validation-valid')
        spanElement.innerHTML = ''
    }
    else {
        e.target.classList.add('input-validator-error')
        spanElement.classList.add('field-validation-error')
        spanElement.classList.remove('field-validation-valid')
        spanElement.innerHTML = e.target.dataset.valRequired
    }
}

const lengthValidator = (value, minLength = 2) => {
    if (value.length >= minLength) {
        return true
    }
    return false
}

const compareValidator = (value, compareWithValue) => {
    if (value === compareWithValue) {
        return true
    }
    return false
}

const checkedValidator = (element) => {   
    if (element.checked) {
        return true
    }
    return false    
    
}

const textValidator = (e) => {
    formErrorHandler(e, lengthValidator(e.target.value))
}

const emailValidator = (e) => {
    const regEx = /^[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z]{2}$/
    formErrorHandler(e, regEx.test(e.target.value))
}

const passwordValidator = (e) => {
    if (e.target.dataset.valEqualtoOther !== undefined) {       
        let referenceFieldName = e.target.dataset.valEqualtoOther.replace('*.', '')      
        let referencedFieldValue = document.querySelector(`input[name="${referenceFieldName}"]`).value
        formErrorHandler(e, compareValidator(e.target.value, referencedFieldValue))
    } else {
        const regEx = /^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!#?@%$])[a-zA-Z0-9!#?@%$]{8,20}$/
        formErrorHandler(e, regEx.test(e.target.value))
    }
}

const checkboxValidator = (e) => {
    formErrorHandler(e, checkedValidator(e.target))
}

let forms = document.querySelectorAll('form')
let inputs = forms[0].querySelectorAll('input')

inputs.forEach(input => {
    if (input.dataset.val === 'true') {
        if (input.type === 'checkbox') {
            input.addEventListener('change', (e) => {
                checkboxValidator(e)
            })
        }
        else {
            input.addEventListener('keyup', (e) => {
                switch (e.target.type) {
                    case 'text':
                        textValidator(e)
                        break;

                    case 'email':
                        emailValidator(e)
                        break;

                    case 'password':
                        passwordValidator(e)
                        break;
                }
            })
        }
    }
})

