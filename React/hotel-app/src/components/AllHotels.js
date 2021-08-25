import React, {useState} from 'react'
import Hotel from './Hotel'

export default function AllHotels( {hotels, onDelete} ) {
    return (
        <div>
            {hotels.map(
                (hotel) => <Hotel hotel={hotel} onDelete={onDelete} />
            )}
        </div>
    )
}
