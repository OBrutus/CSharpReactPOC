import React from 'react';
import ReactDOM from 'react-dom';
import {Formik, Feild, Form, Field} from 'formik'


function App() {
	return (
		<div>
			<h1>Sample Form</h1>
			<Formik
				initialValues = {
					{Demo: "true", 'Ract Learning': 'true'}
				}
				onSubmit = {
					async (value) => {
						await new Promise((resolve) => setTimeout(resolve, 5000));
						alert(JSON.stringify(value, null, 2));
					}
				}
				>
				<Form>
					<Field name="Your Name" type="text" placeHolder="name"/>
					<Field name="Your email" type="email" placeHolder="emial"/>
					<button type='submit'> Submit </button>
				</Form>
			</Formik>
		</div>
	);
}

ReactDOM.render(
	<App />,
	document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
