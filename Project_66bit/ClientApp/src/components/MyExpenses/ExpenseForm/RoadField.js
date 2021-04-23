import React from 'react';

const RoadField = (props) => {
    if (props.render) {
        return (
            <div className="form-group col-md-4">
                <label>Дорога</label>
                <input className="form-control" type="text"></input>
            </div>
        );
    }

    return "";
}

export default RoadField;