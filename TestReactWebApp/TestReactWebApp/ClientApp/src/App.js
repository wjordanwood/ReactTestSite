import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Shared/Layout';
import { Home } from './components/Home';
import { MarketList } from './components/Markets/MarketList';
import { LoginForm } from './components/Authentication/LoginForm'; 
import { ListUsers } from './components/Users/ListUsers'; 

export default class App extends Component {
    displayName = App.name

    render() {
        return (
            <Layout>
                <Route exact path='/' component={Home} />
                <Route path='/markets' component={MarketList} />
                <Route path='/login' component={LoginForm} />
                <Route path='/users' component={ListUsers} />
            </Layout>
        );
    }
}
