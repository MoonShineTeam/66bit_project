import React, { Component } from 'react';
import { Route } from 'react-router';
import { Link } from "react-router-dom";

// Import Styles
import './assets/plugins/bootstrap/css/bootstrap.min.css';
import './css/style.css';

// Import Images
import userPhoto from "./assets/images/users/1.jpg";
import logo from "./assets/images/66bit_logo.png";

// Import Site Components
import { Home } from "./components/Home/Home";
import { MyExpenses } from "./components/MyExpenses/MyExpenses";

export default class App extends Component {
  static displayName = App.name;


  render() {
    return (
      <div id="main-wrapper">
        <header className="topbar">
          <nav className="navbar top-navbar navbar-expand-md navbar-light">

            <div className="navbar-header" style={{ lineHeight: 60 + "px" }}>
              <a className="navbar-brand" href="index.html">
                <img src={logo} alt="logo" />
              </a>
            </div>

            <div className="navbar-collapse ">
              <ul className="navbar-nav mr-auto mt-md-0">

                <li className="nav-item m-l-10">
                  <a href="#" className="nav-link sidebartoggler hidden-sm-down text-muted waves-effect waves-dark">
                    <i className="ti-menu"></i>
                  </a>
                </li>
              </ul>
            </div>
          </nav>
        </header>


        <aside className="left-sidebar">

          <div className="scroll-sidebar p-b-10 border-bottom border-top">
            <div className="user-profile">
              <div className="profile-img">
                <img src={userPhoto} alt="user" />
              </div>
              <div className="profile-text">
                <a href="#" className="dropdown-toggle link u-dropdown" data-toggle="dropdown" role="button"
                  aria-haspopup="true" aria-expanded="true">Name Surname
                            <span className="caret"></span>
                </a>
              </div>
            </div>
          </div>


          <nav className="sidebar-nav p-t-10">
            <ul id="sidebarnav">
              <li>
                <Link to="/home">
                  <i className="mdi mdi-home"></i>
                  <span className="hide-menu">Главная</span>
                </Link>
              </li>
              <li>
                <Link to="/my_expenses">
                  <i className="mdi mdi-menu"></i>
                  <span className="hide-menu">Мои затраты</span>
                </Link>
              </li>

              <li>
                <a href="statistics.html" aria-expanded="false">
                  <i className="mdi mdi-chart-bar"></i>
                  <span className="hide-menu">Статистика</span>
                </a>
              </li>

              <li>
                <a href="help.html" aria-expanded="false">
                  <i className="mdi mdi-help-circle-outline"></i>
                  <span className="hide-menu">Помощь</span>
                </a>
              </li>
            </ul>
          </nav>
        </aside>


        <div className="page-wrapper" style={{ minHeight: "825px" }}>


          <Route path="/home" component={Home}></Route>
          <Route path="/my_expenses" component={MyExpenses}></Route>

          <footer className="footer">
            © 2021 66bit &mdash; Expenses by Moonshine
                </footer>
        </div>
      </div>
    );
  }
}
