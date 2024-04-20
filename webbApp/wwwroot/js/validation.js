document.addEventListener('DOMContentLoaded', function () {
    console.log("Validation.js laddad")

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
        console.log("Inne length")
        if (value.length >= minLength) {
            return true
        }
        return false
    }

    const compareValidator = (value, compareWithValue) => {
        console.log("Inne compare")
        if (value === compareWithValue) {
            return true
        }
        return false
    }

    const checkedValidator = (element) => {
        console.log("Inne checked")
        if (element.checked) {
            return true
        }
        return false
    }

    const textValidator = (e) => {
        console.log("Inne text")
        formErrorHandler(e, lengthValidator(e.target.value))
    }

    const emailValidator = (e) => {
        console.log("Inne email")
        const regEx = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/
        formErrorHandler(e, regEx.test(e.target.value))
    }

    const passwordValidator = (e) => {
        console.log("Inne password")
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
        console.log("Inne checkbox")
        formErrorHandler(e, checkedValidator(e.target))
    }

    let forms = document.querySelectorAll('form')

    forms.forEach(form => { 
        let inputs = form.querySelectorAll('input')

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

        forms.forEach(form => {
            form.addEventListener('submit', function (e) {
                e.preventDefault();
                let isValid = true;

                inputs.forEach(input => {
                    input.dispatchEvent(new Event('keyup'));
                    if (input.classList.contains('input-validator-error')) {
                        isValid = false;
                    }
                })

                if (isValid) {
                    this.submit();
                    console.log('submit');
                } else {
                    console.log('Fel format, ej submit');
                }
            })
        })
    })
    

    
})