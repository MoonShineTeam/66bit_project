import React from 'react'
import "./modal.css"

export const Modal = ({ active, setActive, children }) => {
    return (
        <div className={active ? "modal-container active" : "modal-container"} onClick={() => setActive(false)}>
            <div className={active ? "modal-content active" : "modal-content"} onClick={(event) => event.stopPropagation()}>
                {active ? children : () => ""}
            </div>
        </div>
    )
}
