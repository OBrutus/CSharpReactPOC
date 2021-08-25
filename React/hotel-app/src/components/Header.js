import { PropTypes } from 'prop-types'
import React from 'react'
import Button from './Button'

export default function Header({title, addHotel, buttonShow}) {
    return (
        <div>
            <h1>Hotel {title} </h1>
            <Button title={buttonShow? 'Show' : 'HIDE'} onClick={addHotel}/>
        </div>
    )
}

Header.propTypes = {
    title: PropTypes.string.isRequired,
}

// Header.defaultProps = {
//     title: 'undefined hotel name <this is default>'
// }

// export default function Header(props) {
//     return (
//         <div>
//             <h1>Hotel {props.title} </h1>
//         </div>
//     )
// }