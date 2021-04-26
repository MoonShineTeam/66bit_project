import React, { useState } from 'react';
import { Modal } from '../Common/Modal/Modal';
import { ExpenseForm } from "./ExpenseForm/ExpenseForm";

export const MyExpenses = (props) => {
    document.title = "Мои затраты";

    const [modalActive, setModalActive] = useState(false);

    let data = [
        {
            type: "Общий",
            category: "Еда",
            date: new Date(2021, 2, 22),
            amount: 1000,
            status: "Не выплачено"
        },
        {
            type: "Общий",
            category: "Техника",
            date: new Date(2021, 2, 22),
            amount: 700,
            status: "Не выплачено"
        },
        {
            type: "Общий",
            category: "Еда",
            date: new Date(2021, 3, 1),
            amount: 322,
            status: "Ожидает"
        },
        {
            type: "Общий",
            category: "Канцелярия",
            date: new Date(2021, 3, 3),
            amount: 123,
            status: "Ожидает"
        },
        {
            type: "Общий",
            category: "Еда",
            date: new Date(2021, 3, 3),
            amount: 654,
            status: "Выплачено"
        }
    ]

    return (
        <div>
            <div className="row page-titles">
                <div className="col-md-5 align-self-center">
                    <h3 className="text-themecolor">Мои Затраты</h3>
                </div>
            </div>
            
            <div className="container-fluid">
                <div className="row">
                    <div className="col-12">
                        <div className="card">
                            <div className="card-body">

                                <Modal active={modalActive} setActive={setModalActive}>
                                    <ExpenseForm setActive={setModalActive}/>
                                </Modal>

                                <h4 className="card-title">Данные о моих затратах</h4>
                                <h6 className="card-subtitle">Не знаю, что тут можно написать, но пусть будет</h6>

                                <button className="btn btn-success" onClick={() => setModalActive(true)}>Добавить затрату</button>

                                <div className="table-responsive m-t-40">
                                    <table id="my-expenses-table" className="display nowrap table table-hover table-striped table-bordered" cellSpacing="0" width="100%">
                                        <thead>
                                            <tr>
                                                <th>Тип</th>
                                                <th>Категория</th>
                                                <th>Дата</th>
                                                <th>Сумма</th>
                                                <th>Статус</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            {data.map(properties => <tr>{Object.values(properties).map(e => {
                                                if (e instanceof Date) {
                                                    return <td>{e.toLocaleString("ru", { year: 'numeric', month: 'numeric', day: "numeric" })}</td>
                                                }
                                                return <td>{e}</td>
                                            })}</tr>)}
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    )

}
