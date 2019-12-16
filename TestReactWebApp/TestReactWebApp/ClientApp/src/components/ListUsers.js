import React, { Component } from 'react';
import { Row, Col } from 'react-bootstrap';

export class ListUsers extends Component {
    static renderUsersTable(users) {
        return (
            <table className="table">
                <thead>
                    <tr>
                        <th>User ID</th>
                        <th>First Name</th>
                        <th>Last Name</th>
                        <th>Username</th>
                    </tr>
                </thead>
                <tbody>
                    {users.map(user =>
                        <tr key={user.id}>
                            <td>{user.id}</td>
                            <td>{user.firstName}</td>
                            <td>{user.lastName}</td>
                            <td>{user.username}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    displayName = ListUsers.name

    constructor(props) {
        super(props);
        this.state = {
            users: [],
            loading: true
        };

        fetch('api/User/GetUsers')
        .then(response => response.json())
        .then(data => {
            if (data.success) {
                this.setState({
                    users: data.users,
                    loading: false
                });
            }
            else {
                console.error(data.message);
            }
        })
        .catch((error) => {
            console.error(error);
        });
    }



    render() {
        let contents = this.state.loading
            ? <p><em> Loading... </em></p>
            : ListUsers.renderUsersTable(this.state.users);

        return (
            <div>
                <h1>Users</h1>
                {contents}
            </div>
        );
    }
}
