import * as React from 'react';
import { Link, NavLink } from 'react-router-dom';

interface TopQuestionsState {
    filters: string[];
    currentFilter: string;
    questions: string[];
}

export class TopQuestions extends React.Component<TopQuestionsState> {
    constructor() {
        super();

        this.state = { filters: [], currentFilter: null, questions: [] };
    }

    public render() {

        return <div className="top-questions">
            <div className="head">
                <h1 className="col-sm-6 float-left">
                    Top Questions
                    </h1>
                <div className="col-sm-6 float-right">
                    <Link className="ask-question btn-primary" to={'/ask'}>Ask Question</Link>
                </div>
            </div>
            <div className="filters">
                {this.state.filters}
            </div>
        </div>;
    }
}