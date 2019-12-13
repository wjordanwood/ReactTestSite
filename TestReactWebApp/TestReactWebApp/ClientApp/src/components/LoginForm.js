import React, { Component } from 'react';
import { Row, Col } from 'react-bootstrap';

export class LoginForm extends Component {
    displayName = LoginForm.name

    constructor(props) {
        super(props);
        this.state = {
            username: "",
            password: ""
        };

        this.handleInputChange = this.handleInputChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    handleSubmit(event) {
        fetch('api/SampleData/Login', {
                method: 'POST',
                headers: {
                    Accept: 'application/json',
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify({
                    username: this.state.username,
                    password: this.state.password
                })
            })
            .then(response => response.json())
            .then(data => {
                if (data.success) {
                    alert(data.message);
                }
                else {
                    console.error(data.message);
                }
            })
            .catch((error) => {
                console.error(error);
            });
        event.preventDefault();
    }

    handleInputChange(event) {
        const target = event.target;
        const value = target.value;
        const name = target.name;

        this.setState({
            [name]: value
        });
    }

    render() {
        return (
            <div>
                <h1>Login</h1>
                <form onSubmit={this.handleSubmit}>
                    <Row>
                        <Col xs={12} sm={6} md={3} className="form-group">
                            <label>Username: </label>
                            <input
                                name="username"
                                type="text"
                                onChange={this.handleInputChange}
                                className="form-control"
                                placeholder="Username"
                            />
                        </Col>
                        <Col xs={12} sm={6} md={3} className="form-group">
                            <label>Password: </label>
                            <input
                                name="password"
                                type="password"
                                onChange={this.handleInputChange}
                                className="form-control"
                                placeholder="Password"
                            />
                        </Col>
                    </Row>

                    <Row>
                        <Col sm={12}>
                            <button type="submit" className="btn btn-primary">Submit</button>
                        </Col>
                    </Row>
                </form>
            </div>
        );
    }
}
