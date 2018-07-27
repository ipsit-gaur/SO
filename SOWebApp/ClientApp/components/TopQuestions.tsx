import * as React from 'react';
import { Link, NavLink } from 'react-router-dom';
import { Question } from './Question';

interface TopQuestionsState {
    filters: string[];
    currentFilter: string;
    questions: QuestionState[];
}

export class TopQuestions extends React.Component<{}, TopQuestionsState> {
    constructor() {
        super();
        this.state = { filters: [], currentFilter: '', questions: [] };

        fetch('api/Questions')
            .then(response => response.json() as Promise<QuestionState[]>)
            .then(data => {
                this.setState({ questions: data });
            });
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
            </div>

            <div className="ques-wrapper">
                {this.state.questions.map(question => <Question value={question} key={question.id} />)}
            </div>
        </div>;
    }
}

export interface QuestionState {
    votes: number;
    answers: number;
    views: number;
    description: string;
    tags: string[];
    timeAsked: string;
    id: number;
    author: string;
}