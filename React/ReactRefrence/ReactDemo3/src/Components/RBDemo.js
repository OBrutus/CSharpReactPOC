import React, { useState } from "react";
import Jumbotron from "react-bootstrap/Jumbotron";
import Toast from "react-bootstrap/Toast";
import Button from "react-bootstrap/Button";
import Container from "react-bootstrap/Container";

const RBDemo = () => {
  const [show, setShow] = useState(false);
  return (
    <Container className="p-5">
      <Jumbotron>
        <Toast onClose={() => setShow(false)} show={show} delay={2000} autohide>
          <Toast.Header>Sample toast from RB</Toast.Header>
          <Toast.Body>Say hello!!</Toast.Body>
        </Toast>
        <Button onClick={() => setShow(true)}>Toasting..</Button>
      </Jumbotron>
    </Container>
  );
};

export default RBDemo;
