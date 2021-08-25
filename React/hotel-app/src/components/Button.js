import React from 'react'
import PropTypes from 'prop-types'

export default function Button({title, onClick}) {
    return (
        <button onClick = {onClick}>
            {title}
        </button>
    )
}

Button.propTypes = {
    text: PropTypes.string.isRequired,
}

Button.defaultProps = {
    
}
