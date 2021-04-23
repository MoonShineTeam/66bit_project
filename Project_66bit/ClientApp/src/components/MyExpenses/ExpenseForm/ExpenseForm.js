import React, { useEffect, useState } from 'react';

import AccommodationField from './AccommodationField';
import ProjectField from './ProjectField';
import RoadField from './RoadField';
import TransportField from './TransportField';



export const ExpenseForm = (props) => {
    document.title = "Добавление затраты";

    const [types, setTypes] = useState([]);
    const [categories, setCategories] = useState([]);
    const [isProjectExpense, setProjectExpense] = useState(false);
    const [isMissionExpense, setMissionExpense] = useState(false);

    function getTypes() {
        fetch("https://localhost:44355/type/all")
            .then(res => res.json())
            .then(result => {
                setTypes(result);
            });
    }

    useEffect(() => {
        getTypes();
    }, []);

    function typeChange(event) {
        if (event.target.value !== "null") {
            fetch(`https://localhost:44355/category/typeid/${event.target.value}`)
                .then(res => res.json())
                .then(result => {
                    setCategories(result);
                });


            if (event.target.value === "2") {
                setMissionExpense(true);
                return;
            }
        }

        setCategories([]);
        setMissionExpense(false);
    }

    return (
        <div className="card-body">
            <h4 className="card-title">Затраты</h4>
            <form className="form-material m-t-40 row">

                <AccommodationField render={isMissionExpense}></AccommodationField>
                <RoadField render={isMissionExpense}></RoadField>
                <TransportField render={isMissionExpense}></TransportField>

                <div className="form-group col-md-4">
                    <label>Тип</label>
                    <select name="type-select" className="form-control" onChange={typeChange} onLoad={typeChange}>
                        <option value="null">Выбрать...</option>
                        {types.map(e => <option value={e.id}>{e.name}</option>)}
                    </select>
                </div>

                <div className="form-group col-md-4">
                    <label>Категория</label>
                    <select name="categort-select" className="form-control">
                        <option value="null">Выбрать...</option>
                        {categories.map(e => <option value={e.id}>{e.name}</option>)}
                    </select>
                </div>

                <div className="form-group col-md-4">
                    <label>Сумма</label>
                    <input className="form-control" type="number"></input>
                </div>

                <ProjectField render={isMissionExpense || isProjectExpense}></ProjectField>

                <div className="form-group col-md-8">
                    <label>Описание</label>
                    <textarea className="form-control" rows="10"></textarea>
                </div>

                <div className="form-group col-md-4">
                    <label>Дата</label>
                    <input className="form-control" type="date" placeholder="дд.мм.гггг"></input>
                </div>

                <div className="form-group col-md-8">
                    <label>Чек</label>
                    <div className="dropify-wrapper">
                        <input className="form-control dropify" type="file" id="formFile"></input>
                    </div>
                </div>

                <div className="form-group col-md-4 d-flex align-items-center justify-content-center">
                    <div className="d-block">
                        <button type="button" className="btn btn-success w-100 mt-3">Добавить</button>
                        <button onClick={() => props.setActive(false)} type="button" className="btn btn-danger w-100 mt-3">Отмена</button>
                    </div>
                </div>
            </form>
        </div>

    );

}