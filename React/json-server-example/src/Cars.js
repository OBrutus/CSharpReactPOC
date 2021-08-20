function getCars() {
    fetch('http://localhost:8000/')
}

function Cars(){
    getCars();
    return (
        <>
            Cars list
        </>
    )
}