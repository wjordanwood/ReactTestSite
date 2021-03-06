import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Counter } from './components/Counter';
import { LoginForm } from './components/LoginForm'; 
import { ListUsers } from './components/ListUsers'; 

export default class App extends Component {
    displayName = App.name

    render() {
        return (
            <Layout>
                <Route exact path='/' component={Home} />
                <Route path='/counter' component={Counter} />
                <Route path='/login' component={LoginForm} />
                <Route path='/users' component={ListUsers} />
            </Layout>
        );
    }
}
