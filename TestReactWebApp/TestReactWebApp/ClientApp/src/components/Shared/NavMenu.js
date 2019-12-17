import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import { Glyphicon, Nav, Navbar, NavItem } from 'react-bootstrap';
import { LinkContainer } from 'react-router-bootstrap';
import './NavMenu.css';

export class NavMenu extends Component {
    displayName = NavMenu.name

    render() {
        return (
            <Navbar inverse fixedTop fluid collapseOnSelect>
                <Navbar.Header>
                    <Navbar.Brand>
                        <Link to={'/'}>Test React App</Link>
                    </Navbar.Brand>
                    <Navbar.Toggle />
                </Navbar.Header>
                <Navbar.Collapse>
                    <Nav>
                        <LinkContainer to={'/'} exact>
                            <NavItem>
                                <Glyphicon glyph='home' /> Home
                            </NavItem>
                        </LinkContainer>
                        <LinkContainer to={'/markets'}>
                            <NavItem>
                                <Glyphicon glyph='th-list' /> Markets
                             </NavItem>
                        </LinkContainer>
                        <LinkContainer to={'/login'}>
                            <NavItem>
                                <Glyphicon glyph='log-in' /> Login
                            </NavItem>
                        </LinkContainer>
                        <LinkContainer to={'/users'}>
                            <NavItem>
                                <Glyphicon glyph='th-list' /> List Users
                            </NavItem>
                        </LinkContainer>
                    </Nav>
                </Navbar.Collapse>
            </Navbar>
        );
    }
}
