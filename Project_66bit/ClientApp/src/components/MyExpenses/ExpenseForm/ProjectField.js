import React from 'react';

const ProjectField = (props) => {
    if (props.render) {
        return (
            <div className="form-group col-md-12">
                <label>Проект</label>
                <select className="form-control">
                    <option>Выбрать...</option>
                    <option value="expenses">Затраты</option>
                </select>
            </div>
        );
    }

    return "";
}

export default ProjectField;