// import bootstrap from 'bootstrap'; 

function Nav() {
	console.log("Nav called ");
	let inlineStyle = {
		padding: "15px",
		margin: "15px",
		boxShadow:'0 2px 3px #ccc',
		border:'2px solid blue',
		marginTop:'50px',
		':hover':{
			background:'white'
		}
	}

	return (
		<nav style={inlineStyle} >
			<a href="http://www.github.com"> GitHub </a>
			<a href="http://www.google.com"> Google </a>
			<a href="http://www.linkedin.com"> Linkedin </a>
			<a href="#"> This link </a>
		</nav>
	);
}

function Header() {
	return (
		<>
			<h1> Welcome to web portal </h1>
			<Nav />
		</>
	);
}

export default Header;