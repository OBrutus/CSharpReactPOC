import React from 'react'
import PropTypes from 'prop-types'

export default function Button({title, clickHandler}) {
    return (
        <button onClick={clickHandler}>
            {title}
        </button>
    )
}

Button.propTypes = {
    text: PropTypes.string.isRequired,
    clickHandler: PropTypes.func.isRequired
}

Button.defaultProps = {
    clickHandler: () => {
        console.log('clicked book room not implemented')
    }
}
