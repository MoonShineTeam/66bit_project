import React from 'react';

export const Home = (props) => {
    document.title = "Главная";

    return (
        <div>
            <div className="row page-titles">
                <div className="col-md-5 align-self-center">
                    <h3 className="text-themecolor">Главная</h3>
                </div>
            </div>

            <div className="container-fluid">
                <div className="row">
                    <div className="col-12"  >
                        <div className="card">
                            <div className="card-body">
                                Здесь будет главная страница
                            </div>
                        </div>
                    </div>
                </div>
            </div>


        </div>
    )

}
